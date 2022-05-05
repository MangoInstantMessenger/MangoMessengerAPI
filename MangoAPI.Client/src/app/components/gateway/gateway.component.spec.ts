import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GatewayComponent } from './gateway.component';

describe('GatewayComponent', () => {
  let component: GatewayComponent;
  let fixture: ComponentFixture<GatewayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GatewayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GatewayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
