import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Mango Messenger';

  constructor(private route: ActivatedRoute, private router: Router) {
  }

  navigateFirst(): void {
    this.router.navigate(['first-component'], {skipLocationChange: true}).then(r => r);
  }

  navigateSecond(): void {
    this.router.navigate(['second-component'], {skipLocationChange: true}).then(r => r);
  }

  ngOnInit(): void {
    // https://localhost:5001/app?methodName=testMethod&requestId=1337
    // https://localhost:5001/?methodName=testMethod&requestId=1337
    // http://localhost:4200/?methodName=testMethod&requestId=1337
    // http://localhost:4200/app?methodName=testMethod&requestId=1337
    this.route.queryParams.subscribe(params => {
      console.log(params);
      const methodName = params['methodName'];
      const requestId = params['requestId'];
      console.log('method name: ' + methodName);
      console.log('request id: ' + requestId);
    })
  }
}
