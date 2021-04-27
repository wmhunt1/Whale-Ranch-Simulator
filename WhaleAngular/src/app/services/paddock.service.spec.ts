import { TestBed } from '@angular/core/testing';

import { PaddockService } from './paddock.service';

describe('PaddockService', () => {
  let service: PaddockService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PaddockService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
