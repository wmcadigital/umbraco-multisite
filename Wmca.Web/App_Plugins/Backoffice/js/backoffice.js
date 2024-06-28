const ajax = new XMLHttpRequest();
    ajax.open('GET', 'https://cloudcdn.wmca.org.uk/designsystem/0.0.3/img/ds-icons.min.svg', true);
    ajax.send();
    ajax.onload = function () {
      const div = document.createElement('div');
      div.style.display = 'none';
      div.innerHTML = ajax.responseText;
      document.body.insertBefore(div, document.body.childNodes[0]);
};