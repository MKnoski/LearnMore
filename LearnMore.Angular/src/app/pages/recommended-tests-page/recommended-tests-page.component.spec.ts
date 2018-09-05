import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecommendedTestsPageComponent } from './recommended-tests-page.component';

describe('RecommendedTestsPageComponent', () => {
  let component: RecommendedTestsPageComponent;
  let fixture: ComponentFixture<RecommendedTestsPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecommendedTestsPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecommendedTestsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
