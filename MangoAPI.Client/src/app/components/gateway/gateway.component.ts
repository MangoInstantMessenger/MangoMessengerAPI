import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RoutingService } from '../../services/messenger/routing.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-gateway',
  templateUrl: './gateway.component.html'
})
export class GatewayComponent implements OnInit, OnDestroy {
  constructor(private route: ActivatedRoute, private routingService: RoutingService) {}

  componentDestroyed$: Subject<boolean> = new Subject();

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  ngOnInit(): void {
    this.route.queryParams.pipe(takeUntil(this.componentDestroyed$)).subscribe((params) => {
      const methodName = params['methodName'];
      this.routingService.matchMethodName(methodName);
    });
  }
}
