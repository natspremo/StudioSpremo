import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HpDataAdminComponent } from './hp-data-admin.component';

describe('HpDataAdminComponent', () => {
  let component: HpDataAdminComponent;
  let fixture: ComponentFixture<HpDataAdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HpDataAdminComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HpDataAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
