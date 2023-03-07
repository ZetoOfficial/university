"use strict";

const modal = document.getElementById("myModal");
const closeBtn = document.querySelector(".close");

closeBtn.addEventListener("click", () => {
  modal.style.display = "none";
});

window.addEventListener("click", (event) => {
  if (event.target === modal) {
    modal.style.display = "none";
  }
});

function showModal() {
  modal.style.display = "block";
}
