import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckEmailNoteComponent } from './check-email-note.component';

describe('ConfirmRegistrationNoteComponent', () => {
  let component: CheckEmailNoteComponent;
  let fixture: ComponentFixture<CheckEmailNoteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CheckEmailNoteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CheckEmailNoteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
