export enum Status {
  OK = "OK",
  Warning = "Warning",
  Error = "Error",
}

export interface Item {
  latitude: number;
  longitude: number;
  status: Status;
}

export type MapPoint = {
  latitude: number;
  longitude: number;
};
