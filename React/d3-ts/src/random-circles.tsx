import "./random-circles.css";
import React, { useRef } from "react";
import { FC } from "react";
import * as d3 from "d3";

const RandomCircles: FC = () => {
  const ref = useRef<SVGSVGElement>(undefined);

  setInterval(() => {
    const width = ref.current.clientWidth;
    const height = ref.current.clientHeight;

    d3.select(ref.current)
      .append("circle")
      .attr("cx", Math.random() * width)
      .attr("cy", Math.random() * height)
      .attr("r", 30)
      .classed("circle", true);
  }, 1000);

  return <svg className="container" ref={ref}></svg>;
};

export default RandomCircles;
