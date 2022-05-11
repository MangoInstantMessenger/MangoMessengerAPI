import {ComponentFixture, TestBed} from '@angular/core/testing';

import {RestorePasswordComponent} from './restore-password.component';

describe('RestorePasswordComponent', () => {
  let component: RestorePasswordComponent;
  let fixture: ComponentFixture<RestorePasswordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RestorePasswordComponent]
    })
      .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RestorePasswordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
