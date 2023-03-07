"use strict";

let figureClickCounter = 0;
let lastClickedFigure = null;
const clickCounter = document.getElementById("counter");
const shapesRow = document.getElementById("shapes-row");

clickCounter.textContent = figureClickCounter;

function addFigureClick(figure) {
  if (figure.classList.contains("figure-click")) {
    figure.classList.remove("figure-click");
    figureClickCounter--;
  } else {
    figure.classList.add("figure-click");
    figureClickCounter++;
  }

  clickCounter.textContent = figureClickCounter;

  if (figure === lastClickedFigure) {
    figure.classList.remove("pulse");
  }

  figure.classList.add("pulse");
  if (lastClickedFigure) {
    lastClickedFigure.classList.remove("pulse");
  }
  lastClickedFigure = figure;
}

function createObject(objectType) {
  const element = document.createElement("div");
  element.addEventListener("click", () => addFigureClick(element));

  element.classList.add(objectType);
  shapesRow.appendChild(element);
}

function clearFigures() {
  while (shapesRow.lastChild) {
    shapesRow.removeChild(shapesRow.lastChild);
  }
}
