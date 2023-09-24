import { Component } from '@angular/core';

@Component({
  selector: 'app-timer',
  templateUrl: './timer.component.html',
  styleUrls: ['./timer.component.scss'],
})
export class TimerComponent {

  timerValue: string = "100";
  timerInterval: number = 0;

  onStartTimer() {
    this.timerInterval = this.timerInterval * 60
    var initValue = this.timerInterval
    let intervalId = setInterval(() => {
      this.timerInterval = this.timerInterval - 1;
      console.log(this.timerInterval)
      if(this.timerInterval === 0) clearInterval(intervalId)
      this.timerValue = ((this.timerInterval/initValue)*100).toString()
  }, 1000)
  }

}
