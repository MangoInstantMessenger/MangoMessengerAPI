import {ComponentFixture, TestBed} from '@angular/core/testing';

import {RestorePasswordRequestComponent} from './restore-password-request.component';

describe('RestorePasswordRequestComponent', () => {
  let component: RestorePasswordRequestComponent;
  let fixture: ComponentFixture<RestorePasswordRequestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RestorePasswordRequestComponent]
    })
      .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RestorePasswordRequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
