import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedirectToConfirmRegistrationComponent } from './redirect-to-confirm-registration.component';

describe('RedirectToConfirmRegistrationComponent', () => {
  let component: RedirectToConfirmRegistrationComponent;
  let fixture: ComponentFixture<RedirectToConfirmRegistrationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RedirectToConfirmRegistrationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RedirectToConfirmRegistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
