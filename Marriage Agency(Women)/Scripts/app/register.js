var toogle = new Toogle();

toogle.button_next.onclick = function () { toogle.toggle_button_next(); }
toogle.button_prev.onclick = function () { toogle.toggle_button_prev(); }



function Toogle() {

    this.button_next = document.getElementById('next');
    this.button_prev = document.getElementById('prev');

    this.scren_1 = document.getElementById('on1');
    this.scren_2 = document.getElementById('on2');
    this.scren_3 = document.getElementById('on3');

    this.counter = 0;


}

Toogle.prototype.toggle_button_next = function () {

    if (this.counter == 0) {
        this.scren_1.classList.remove('displey_block');
        this.scren_1.classList.add('displey_none');
        this.scren_2.classList.add('displey_block');
        this.counter++;
    } else if (this.counter == 1) {
        this.scren_2.classList.remove('displey_block');
        this.scren_2.classList.add('displey_none');
        this.scren_3.classList.add('displey_block');
        this.counter++;
    }
}


Toogle.prototype.toggle_button_prev = function () {

    if (this.counter == 1) {
        this.scren_2.classList.remove('displey_block');
        this.scren_2.classList.add('displey_none');
        this.scren_1.classList.add('displey_block');
        this.counter--;
    } else if (this.counter == 2) {
        this.scren_3.classList.remove('displey_block');
        this.scren_3.classList.add('displey_none');
        this.scren_2.classList.add('displey_block');
        this.counter--;
    }
}