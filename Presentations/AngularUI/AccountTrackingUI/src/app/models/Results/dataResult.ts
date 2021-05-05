import { Result } from './result';

export interface DataResult<T> extends Result {
  data: T;
}
