import { VisSingleContainer, VisTopoJSONMap } from "@unovis/react";
import { MapData } from "@unovis/ts";
import { WorldMapTopoJSON } from "@unovis/ts/maps";
import { FC } from "react";
import { Item, MapPoint } from "../types";

interface Props {
  items: Item[];
}

const TopoMap: FC<Props> = ({ items }) => {
  const generateData = (
    items: Item[]
  ): MapData<undefined, MapPoint, undefined> => {
    const data: MapData<undefined, MapPoint, undefined> = {
      points: items.map((item) => ({
        latitude: item.latitude,
        longitude: item.longitude,
      })),
    };

    return data;
  };

  const data = generateData(items);
  return (
    <VisSingleContainer data={data}>
      <VisTopoJSONMap topojson={WorldMapTopoJSON} />
    </VisSingleContainer>
  );
};

export default TopoMap;
