import { BaseObject } from "./BaseObject";

export enum EnumSubject {
  ENGLISH,
  MATH,
  HISTORY,
  GEOGRAPHY,
  SCIENCE,
  PHYSICS,
  CHEMISTRY,
  BIOLOGY,
  PHILOSOPHY,
  ART,
  MUSIC,
  SPORT,
  COMPUTER_SCIENCE,
  FRENCH,
  SPANISH,
}

export interface Subject extends BaseObject {


}

export class Subject implements Subject {
  constructor() {
  }
}
