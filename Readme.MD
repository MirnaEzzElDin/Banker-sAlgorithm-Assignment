# Welcome to our Banker's Algorithm Project! 🎉

This project is all about managing resources and avoiding those pesky deadlocks. It's written in C#, and we've got a cool GUI using Windows Forms.

## 📂 Main Parts of the Project
---
### 🧠 BankersAlgorithm.cs 

This is the brain of our project, where the real action happens! Here's what each part does:

- `BankersAlgorithm()`: This is like a welcome party for our Banker's Algorithm. It sets everything up, making sure we know the number of processes, total resources, and what's currently available.
- `IsRequestValid()`: This is the bouncer of our party. It checks if a process can get the resources it wants. It's like making sure no one's asking for more pizza than we have.
- `UpdateResources()`: Once a request passes the bouncer, this part updates our resource status, kinda like ticking off who's got their pizza.
- `ArrayLessThanOrEqual()` and `GetRow()`: These are our handy helpers. They're great for comparing lists of stuff (arrays) and picking out a specific line of info from a table (a row from a matrix).
- `IsSystemSafe()`: This is the safety check. It's like making sure we've got a game plan that won't end in chaos. Specifically, it finds a safe order for processes to happen so they can all finish without any deadlock.
- `RequestResources()`: This is the process manager. It checks a resource request, gives out resources temporarily, and makes sure everything's still safe. If all's good, the request is granted. If not, it takes back the resources and says 'nope' to the request.

### 🎨 Form1.cs 

This file is our party planner, setting up how everything looks:

- `Form1()`: This is where our form gets set up.
- `btnCheckRequest_Click()`: This is the part that reacts when you click the 'Check Request' button. It reads what you put in, creates a new BankersAlgorithm, and calls `RequestResources()`. Then it lets you know if your request got through.
- `RefreshData()`: This part tidies up after a resource request, making sure the data you see is up-to-date.
- `VectorToString()`, `MatrixToString()`, `ReadVector()`, `ReadMatrix()`: These helpers convert between text and numbers, making sure the app understands your inputs and can show you the results.

### 🎬 AlgorithmStepsForm.cs 

This is our backstage pass, letting you see the step-by-step action:

- `AlgorithmStepsForm()`: This is where our step-by-step form gets set up. There's also a version that takes the steps of the algorithm and the need matrix so you can see the details of a request.
- `ConvertNeedToDataTable()`: This part turns the need matrix into a table for the DataGridView control on the form. It's all about showing you the info in a clear way.

## 🎟 How to Join the Party?
---
First, you've got to run the program. You can do this from the files. Look for the shortcut named "BankersAlgorithm applet". Make sure you've got the right .net framework version installed. If not, no worries! If you have Visual Studio Community installed, just open the solution file, build it, and you're good to go.

After running, you will see 2 textboxes at the top which are for the user to input the total resources and the available resources as a vector separated by spaces, **BUT PLEASE DON'T LEAVE A SPACE AT THE END OF THE VECTOR**, it won't throw an exception error but it will show a message stating that the input provided is not in the correct format and will ask you to remove any extra spaces.

After you have filled those vectors, there will be two matrices underneath them which you can enter the values in like this:
```
1 2 3
3 4 5
5 6 7
```

Basically normal rows and columns but separated by spaces. I apologize for not making it more fancy, its just that time wasn't on my side.

After filling the matrices, choose a process from the "Numeric Up Down" box, and enter the resources that are requested by that process. Please note that the processes start from P0.

After you are done with filling in all the data, click on the **Check Request** button, which will check if the request is denied or granted, and will show a new form containing all the steps that took place in the algorithm and the safe sequence it took.

After you close the form that popped up, the available resources, and the allocated resources should update. And that's it!
