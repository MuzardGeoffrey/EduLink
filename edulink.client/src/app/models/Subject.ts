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

export enum enumLevelString {
  //creche = 0
  creche = 0,

  //maternelle = 10
  petiteSection = 10,
  moyenneSection = 11,
  grandeSection = 12,

  //primaires = 20
  CP = 20,
  CE1 = 21,
  CE2 = 22,
  CM1 = 23,
  CM2 = 24,

  //collège = 30
  sixième = 30,
  cinquième = 31,
  quatrième = 32,
  troisième = 33,

  //lycée = 40
  seconde = 40,
  première = 41,
  terminale = 42,

  //université = 50
}

export interface Subject extends BaseObject {
  enumSubject: EnumSubject;
  level: number;
}

export class Subject implements Subject {
  constructor() {
    this.enumSubject = EnumSubject.ENGLISH;
    this.level = enumLevelString.sixième;
  }
}
