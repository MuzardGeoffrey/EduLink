export abstract class BaseObject {
  id: number = 0;
  createdDate: Date = new Date;
  lastUpdateDate?: Date;

  //constructor(id?: number, createdDate?: Date, lastUpdateDate?: Date) {
  //  if (id !== undefined) {
  //    this.id = id;
  //  }
  //  if (createdDate !== undefined) {
  //    this.createdDate = createdDate;
  //  }
  //  if (lastUpdateDate !== undefined) {
  //    this.lastUpdateDate = lastUpdateDate;
  //  }
//}
}
