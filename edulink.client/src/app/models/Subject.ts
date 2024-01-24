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

export class Subject extends BaseObject {
  enumSubject: EnumSubject;
  level: number | undefined;

  constructor(enumSubject: EnumSubject, level?: number, id?: number, createdDate?: Date, lastUpdateDate?: Date) {
    super(id, createdDate, lastUpdateDate)
    this.enumSubject = enumSubject;
    if (level !== undefined) {
      this.level = level;
    }
  }

  set(enumSubject: EnumSubject) {
    this.enumSubject = enumSubject;
    return this;
  }
}
