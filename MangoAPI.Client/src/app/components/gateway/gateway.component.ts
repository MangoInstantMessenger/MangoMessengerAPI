import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {RoutingService} from "../../services/routing.service";
import {SessionService} from "../../services/session.service";

@Component({
  selector: 'app-gateway',
  templateUrl: './gateway.component.html'
})
export class GatewayComponent implements OnInit {
  constructor(private route: ActivatedRoute,
              private router: Router,
              private routingService: RoutingService,
              private sessionService: SessionService) {}

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      const methodName = params['methodName'];
      this.routingService.matchMethodName(methodName);
    });
  }
}
