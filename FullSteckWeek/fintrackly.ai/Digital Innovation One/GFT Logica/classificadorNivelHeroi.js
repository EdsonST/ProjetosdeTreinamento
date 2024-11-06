//Desafio classificador nível de herói.

let nomeDoHeroi = "Edson";
let nivelDoHeroi = 13000;

//Classificação
if (nivelDoHeroi <= 1000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Ferro");
} else if (nivelDoHeroi <= 2000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Bronze");
} else if (nivelDoHeroi <= 5000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Prata");
} else if (nivelDoHeroi <= 7000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Ouro");
} else if (nivelDoHeroi <= 8000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Platina");
} else if (nivelDoHeroi <= 9000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Ascendente");
} else if (nivelDoHeroi <= 10000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Imortal");
} else if (nivelDoHeroi > 10000) {
    console.log("O Herói de nome "+ nomeDoHeroi+ " está no nível de Radiante");
}