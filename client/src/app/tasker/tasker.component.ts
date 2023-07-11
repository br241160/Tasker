import { Component, ElementRef, Input, ViewChild } from '@angular/core';

@Component({
  selector: 'app-tasker',
  templateUrl: './tasker.component.html',
  styleUrls: ['./tasker.component.scss']
})
export class TaskerComponent {

  tasks: any [] = ["str1", "str2", "str3"];
  @ViewChild('taskName') taskName?: ElementRef;

  clearTasks(){
    this.tasks.pop;
  }
  
  addTask(){
    this.tasks.push(this.taskName?.nativeElement.value);
  }

}
