import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminOtpremniceComponent } from './admin-otpremnice.component';

describe('AdminOtpremniceComponent', () => {
  let component: AdminOtpremniceComponent;
  let fixture: ComponentFixture<AdminOtpremniceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminOtpremniceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminOtpremniceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
