import * as d from "../../data.json" assert { type: "json" };

let data = JSON.parse(JSON.stringify(d.default));

const source = document.getElementById("template").innerHTML;
const template = Handlebars.compile(source);

console.log(template(data));
document.getElementById("root").innerHTML = template(data);
