import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TaskerComponent } from './tasker/tasker.component';
import { TimerComponent } from './timer/timer.component';



const routes: Routes = [
  {path: 'tasker', component: TaskerComponent},
  {path: 'timer', component: TimerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
