import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {RoutingService} from "../../services/routing.service";

@Component({
  selector: 'app-gateway',
  templateUrl: './gateway.component.html',
  styleUrls: ['./gateway.component.scss']
})
export class GatewayComponent implements OnInit {
  constructor(private route: ActivatedRoute,
              private router: Router,
              private routingService: RoutingService) {}

  ngOnInit(): void {
    this.router
      .navigate(['chats'], { skipLocationChange: true })
      .then((r) => r);

    this.route.queryParams.subscribe(params => {
      console.log(params);
      const methodName = params['methodName'];
      this.routingService.matchMethodName(methodName);
    })
  }
}
