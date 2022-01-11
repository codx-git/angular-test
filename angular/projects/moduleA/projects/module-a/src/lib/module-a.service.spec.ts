import { TestBed } from '@angular/core/testing';

import { moduleAService } from './module-a.service';

describe('moduleAService', () => {
  let service: moduleAService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(moduleAService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
