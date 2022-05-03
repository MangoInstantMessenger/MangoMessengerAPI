import {Component} from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Mango Messenger';

  constructor(private route: ActivatedRoute, private router: Router) {
  }

  navigateFirst(): void {
    this.router.navigate(['first-component'], {skipLocationChange: true}).then(r => r);
  }

  navigateSecond(): void {
    this.router.navigate(['second-component'], {skipLocationChange: true}).then(r => r);
  }
}
