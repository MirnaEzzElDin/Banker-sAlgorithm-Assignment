using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banker_s_algo
{
    public class BankersAlgorithm
    {
        public int[,] allocation;
        public int[,] maximum;
        public int[,] need;
        public int[] available;
        public int[] totalResources;
        private int numProcesses;
        private int numResources;

        public struct RequestResult
        {
            public bool Granted { get; set; }
            public List<string> Steps { get; set; }
        }

        public BankersAlgorithm(int[,] allocation, int[,] maximum, int[] totalResources, int[] available)
        {
            this.allocation = allocation;
            this.maximum = maximum;
            this.totalResources = totalResources;
            numProcesses = allocation.GetLength(0);
            numResources = totalResources.Length;
            CalculateAvailable();
   

            // Ensure the dimensions of maximum and allocation matrices match the number of resources
            if (maximum.GetLength(1) != numResources || allocation.GetLength(1) != numResources)
            {
                throw new ArgumentException("The dimensions of the maximum and allocation matrices must match the number of resources.");
            }

            CalculateNeed();
        }

        private void CalculateAvailable()
        {
            available = new int[numResources];
            for (int i = 0; i < numResources; i++)
            {
                available[i] = totalResources[i];
                for (int j = 0; j < numProcesses; j++)
                {
                    available[i] -= allocation[j, i];
                }
            }
        }

        private void CalculateNeed()
        {
            need = new int[numProcesses, numResources];
            for (int i = 0; i < numProcesses; i++)
            {
                for (int j = 0; j < numResources; j++)
                {
                    need[i, j] = maximum[i, j] - allocation[i, j];
                }
            }
        }

        private (bool, string) IsRequestValid(int processId, int[] request)
        {
            for (int i = 0; i < numResources; i++)
            {
                if (request[i] > need[processId, i])
                {
                    return (false, $"Requested resource {i} exceeds the need of process {processId}.");
                }
                if (request[i] > available[i])
                {
                    return (false, $"Requested resource {i} exceeds the available resources.");
                }
            }
            return (true, null);
        }

        private void UpdateResources(int processId, int[] request, bool allocate, List<string> steps)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Temporarily update the available resources after {(allocate ? "allocating" : "deallocating")} the request to Process {processId}: ");
            sb.Append("(" + string.Join(", ", available.Select((x, i) => $"{x}-{request[i]}")) + ") = ");
            for (int i = 0; i < numResources; i++)
            {
                if (allocate)
                {
                    available[i] -= request[i];
                    allocation[processId, i] += request[i];
                    need[processId, i] -= request[i];  // update need when allocating resources
                }
                else
                {
                    available[i] += request[i];
                    allocation[processId, i] -= request[i];
                    need[processId, i] += request[i];  // update need when deallocating resources
                }
            }
            sb.Append("(" + string.Join(", ", available) + ")");
            steps.Add(sb.ToString());
        }


        private bool ArrayLessThanOrEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must be of equal length.");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private int[] GetRow(int[,] matrix, int row)
        {
            var columns = matrix.GetLength(1);
            var array = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                array[i] = matrix[row, i];
            }
            return array;
        }


        public bool IsSystemSafe(out List<string> safetySteps)
        {
            safetySteps = new List<string>();

            int[] work = (int[])available.Clone();
            bool[] finish = new bool[numProcesses];

            while (true)
            {
                int i;
                for (i = 0; i < numProcesses; i++)
                {
                    if (!finish[i] && ArrayLessThanOrEqual(GetRow(need, i), work))
                    {
                        safetySteps.Add($"Process {i} can execute because its need {VectorToString(GetRow(need, i))} is less than or equal to the available resources {VectorToString(work)}. After Process {i} finishes, update the available resources: ({VectorToString(work.Select((x, j) => $"{x}+{GetRow(allocation, i)[j]}").ToArray())}) = ");

                        for (int j = 0; j < numResources; j++)
                        {
                            work[j] += allocation[i, j];
                        }

                        safetySteps[safetySteps.Count - 1] += $"({VectorToString(work)})";
                        finish[i] = true;
                        break;
                    }
                }

                if (i == numProcesses) // No process could be found in the last pass
                {
                    return finish.All(x => x);
                }
            }
        }


        private string VectorToString(int[] vector)
        {
            return "(" + string.Join(", ", vector) + ")";
        }

        private string VectorToString(string[] vector)
        {
            return "(" + string.Join(", ", vector) + ")";
        }

        private bool CanProcessExecute(int processId, int[] work)
        {
            for (int i = 0; i < numResources; i++)
            {
                if (need[processId, i] > work[i])
                {
                    return false;
                }
            }
            return true;
        }

        public RequestResult RequestResources(int processId, int[] request)
        {
            var steps = new List<string>();
            int stepNumber = 1;
            steps.Add($"{stepNumber++}. Process {processId} is requesting resources: {string.Join(", ", request)}.");

            var (valid, message) = IsRequestValid(processId, request);
            if (valid)
            {
                steps.Add($"{stepNumber++}. The request is valid.");
                UpdateResources(processId, request, true, steps);
                steps.Add($"{stepNumber++}. Temporarily allocated requested resources to process {processId}.");

                if (IsSystemSafe(out var safetySteps))
                {
                    steps.AddRange(safetySteps.Select(step => $"{stepNumber++}. {step}"));
                    steps.Add($"{stepNumber++}. The system is in a safe state. The request is granted.");
                    return new RequestResult { Granted = true, Steps = steps };
                }

                UpdateResources(processId, request, false, steps); // Revert the allocation
                steps.Add($"{stepNumber++}. The system would not be in a safe state. The request is denied and the allocation is reverted.");
            }
            else
            {
                steps.Add($"{stepNumber++}. The request is not valid. " + message + " The request is denied.");
            }

            return new RequestResult { Granted = false, Steps = steps };
        }

    }

}
