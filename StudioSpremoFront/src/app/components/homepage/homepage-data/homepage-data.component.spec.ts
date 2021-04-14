import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomepageDataComponent } from './homepage-data.component';

describe('HomepageDataComponent', () => {
  let component: HomepageDataComponent;
  let fixture: ComponentFixture<HomepageDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomepageDataComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HomepageDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
