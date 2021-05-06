import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminTableFlexoComponent } from './admin-table-flexo.component';

describe('AdminTableFlexoComponent', () => {
  let component: AdminTableFlexoComponent;
  let fixture: ComponentFixture<AdminTableFlexoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminTableFlexoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminTableFlexoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
