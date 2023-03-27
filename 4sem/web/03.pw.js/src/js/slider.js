"use strict";

const sliderImages = document.querySelector(".slider-images");
const sliderBack = document.querySelector(".slider-back");
const sliderForward = document.querySelector(".slider-forward");
const sliderCounter = document.querySelector(".slider-counter");
let currentSlide = 0;
const maxSlide = sliderImages.children.length - 1;

function updateSlideCounter() {
  sliderCounter.textContent = `${currentSlide + 1} / ${maxSlide + 1}`;
}

updateSlideCounter();

sliderBack.addEventListener("click", () => {
  if (currentSlide > 0) {
    currentSlide--;
    sliderImages.style.transform = `translateX(-${currentSlide * 600}px)`;
    updateSlideCounter();
    sliderForward.disabled = false;
  }

  if (currentSlide === 0) {
    sliderBack.disabled = true;
  }
});

sliderForward.addEventListener("click", () => {
  if (currentSlide < maxSlide) {
    currentSlide++;
    sliderImages.style.transform = `translateX(-${currentSlide * 600}px)`;
    updateSlideCounter();
    sliderBack.disabled = false;
  }

  if (currentSlide === maxSlide) {
    sliderForward.disabled = true;
  }
});
