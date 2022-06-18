import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedirectToRestorePasswordComponent } from './redirect-to-restore-password.component';

describe('RedirectToRestorePasswordComponent', () => {
  let component: RedirectToRestorePasswordComponent;
  let fixture: ComponentFixture<RedirectToRestorePasswordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RedirectToRestorePasswordComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RedirectToRestorePasswordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
