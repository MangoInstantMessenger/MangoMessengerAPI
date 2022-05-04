import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {FirstComponent} from './first/first.component';
import {SecondComponent} from './second/second.component';
import {AppComponent} from "./app.component";

const routes: Routes = [
  {path: 'first-component', component: FirstComponent},
  {path: 'second-component', component: SecondComponent},
  {path: 'app', component: AppComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
