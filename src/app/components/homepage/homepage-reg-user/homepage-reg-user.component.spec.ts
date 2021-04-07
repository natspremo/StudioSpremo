import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomepageRegUserComponent } from './homepage-reg-user.component';

describe('HomepageRegUserComponent', () => {
  let component: HomepageRegUserComponent;
  let fixture: ComponentFixture<HomepageRegUserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomepageRegUserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HomepageRegUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
