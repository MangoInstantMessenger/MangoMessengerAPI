import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConfirmRegistrationNoteComponent } from './confirm-registration-note.component';

describe('ConfirmRegistrationNoteComponent', () => {
  let component: ConfirmRegistrationNoteComponent;
  let fixture: ComponentFixture<ConfirmRegistrationNoteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConfirmRegistrationNoteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConfirmRegistrationNoteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
