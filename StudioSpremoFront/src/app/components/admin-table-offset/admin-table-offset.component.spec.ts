import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminTableOffsetComponent } from './admin-table-offset.component';

describe('AdminTableOffsetComponent', () => {
  let component: AdminTableOffsetComponent;
  let fixture: ComponentFixture<AdminTableOffsetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminTableOffsetComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminTableOffsetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
