window.onload = function () {
    console.log("debug");
};

function AddProductToCart(productId, productName, price) {
    console.log("debug");
    var count = sessionStorage.getItem(productName + "||" + productId + "||" + price);

    if (count != null) {
        sessionStorage.setItem(productName + "||" + productId + "||" + price, Number(count) + 1);
    } else {
        sessionStorage.setItem(productName + "||" + productId + "||" + price, 1);
    }
};

function RemoveProductFromCart(productId, productName, price) {
    console.log("debug");
    var count = sessionStorage.getItem(productName + "||" + productId + "||" + price);

    if (count != null) {
        if (count == 1) {
            sessionStorage.removeItem(productName + "||" + productId + "||" + price);
        } else {
            sessionStorage.setItem(productName + "||" + productId + "||" + price, Number(count) + 1);
        }
    } else {
        sessionStorage.setItem(productName + "||" + productId + "||" + price, 1);
    }
};