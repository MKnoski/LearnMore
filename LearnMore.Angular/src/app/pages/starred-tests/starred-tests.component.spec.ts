import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StarredTestsComponent } from './starred-tests.component';

describe('StarredTestsComponent', () => {
  let component: StarredTestsComponent;
  let fixture: ComponentFixture<StarredTestsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StarredTestsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StarredTestsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
