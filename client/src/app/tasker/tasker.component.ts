import { Component, ElementRef, Input, ViewChild } from '@angular/core';
import { taskerTask } from '../models/taskerTask';

@Component({
  selector: 'app-tasker',
  templateUrl: './tasker.component.html',
  styleUrls: ['./tasker.component.scss']
})
export class TaskerComponent {

  tasks: taskerTask [] = [
    {id: 1, name: "Clean the house", details: "Just clean it", done: false},
    {id: 2, name: "Make a dinner", details: "Tasty", done: false},
    {id: 3, name: "Buy things", details: "Nice things", done: false}
  ];

  tasksDone: taskerTask [] = [];

  clearTasks(){
    this.tasks.forEach(elem => this.tasks.pop());
    this.tasks.pop();
  }
  
  addTask(name: string, details: string){
    this.tasks.push({id: 1, name, details, done: false});
    console.log("Task name is ", name)
  }


  onTaskDone(id: number){

    var taskIndex = this.tasks.findIndex(elem => elem.id == id);
    var task = this.tasks[taskIndex];
    task.done = true;
    this.tasksDone.push(task);
    this.tasks.splice(taskIndex, 1);

    console.log(this.tasks[taskIndex].done);
    this.tasksDone.push()

  }

}
