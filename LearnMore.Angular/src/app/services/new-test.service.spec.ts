import { TestBed, inject } from '@angular/core/testing';

import { NewTestService } from './new-test.service';

describe('NewTestService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NewTestService]
    });
  });

  it('should be created', inject([NewTestService], (service: NewTestService) => {
    expect(service).toBeTruthy();
  }));
});
