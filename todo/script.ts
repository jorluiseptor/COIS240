class Task {
    complete: boolean = false;
    title: string;  
    static count: number = 0;
    static list: Task[];
    
    constructor(title?:string){
        Task.count ++;
        this.title = title;
    }
}



let taskList: Task[] = [];

function UpdateList(){
    let taskTitle: string = (<HTMLInputElement>document.getElementById('task-title')).value;
    let newTask = new Task(taskTitle);
    taskList.push(newTask);
    console.log(taskList);

    //append list
    let li = document.createElement("li");
    li.appendChild(document.createTextNode(taskTitle));

    document.getElementById('task-list').appendChild(li);
}

let item1 = new Task;
let item2 = new Task;

item1.complete = false;
console.log(item1.complete);
console.log(Task.count);

let item3 = new Task("Lavar ropa");
console.log(Task.count);
console.log(item3.title);

