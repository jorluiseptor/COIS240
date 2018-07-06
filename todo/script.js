var Task = /** @class */ (function () {
    function Task(title) {
        this.complete = false;
        Task.count++;
        this.title = title;
    }
    Task.count = 0;
    return Task;
}());
var taskList = [];
function UpdateList() {
    var taskTitle = document.getElementById('task-title').value;
    var newTask = new Task(taskTitle);
    taskList.push(newTask);
    console.log(taskList);
    //append list
    var li = document.createElement("li");
    li.appendChild(document.createTextNode(taskTitle));
    document.getElementById('task-list').appendChild(li);
}
var item1 = new Task;
var item2 = new Task;
item1.complete = false;
console.log(item1.complete);
console.log(Task.count);
var item3 = new Task("Lavar ropa");
console.log(Task.count);
console.log(item3.title);
