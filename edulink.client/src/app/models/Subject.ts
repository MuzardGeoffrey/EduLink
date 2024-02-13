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
  enumSubject: EnumSubject;
  level: number;

}

export class Subject implements Subject {
  constructor() {
    this.enumSubject = EnumSubject.ENGLISH;
    this.level = 0;
  }
}
