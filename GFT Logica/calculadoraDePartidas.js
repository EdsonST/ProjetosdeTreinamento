<<<<<<< HEAD
function main(vitorias, derrotas) {
    let saldo = saldoRankeadas(vitorias, derrotas);
    let nivel = nivelJogador(saldo);
    console.log("O Herói tem de saldo de " + saldo + " e está no nível de " + nivel);
}

function saldoRankeadas(vitorias, derrotas) {
    return vitorias - derrotas;
}

function nivelJogador(saldoRankeadas) {
    if (saldoRankeadas <= 10) {
        return "Ferro";
    } else if (saldoRankeadas <= 20) {
        return "Bronze";
    } else if (saldoRankeadas <= 50) {
        return "Prata";
    } else if (saldoRankeadas <= 80) {
        return "Ouro";
    } else if (saldoRankeadas <= 90) {
        return "Diamante";
    } else if (saldoRankeadas <= 100) {
        return "Lendário";
    } else {
        return "Imortal";
    }
}

//Teste Função
=======
function main(vitorias, derrotas) {
    let saldo = saldoRankeadas(vitorias, derrotas);
    let nivel = nivelJogador(saldo);
    console.log("O Herói tem de saldo de " + saldo + " e está no nível de " + nivel);
}

function saldoRankeadas(vitorias, derrotas) {
    return vitorias - derrotas;
}

function nivelJogador(saldoRankeadas) {
    if (saldoRankeadas <= 10) {
        return "Ferro";
    } else if (saldoRankeadas <= 20) {
        return "Bronze";
    } else if (saldoRankeadas <= 50) {
        return "Prata";
    } else if (saldoRankeadas <= 80) {
        return "Ouro";
    } else if (saldoRankeadas <= 90) {
        return "Diamante";
    } else if (saldoRankeadas <= 100) {
        return "Lendário";
    } else {
        return "Imortal";
    }
}

//Teste Função
>>>>>>> e59020ce00062d409ee08f95981e1b4ac6b97787
main(30,10)