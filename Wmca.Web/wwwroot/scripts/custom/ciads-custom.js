document.addEventListener("DOMContentLoaded", function () {
  // show / hide form depending on if they are a delivery partner
  var radios = document.querySelectorAll(
    "input[type=radio][name=deliveryPartner]"
  );
  radios.forEach(function (radio) {
    radio.addEventListener("change", function () {
      if (this.value == "Yes") {
        document.getElementById("formYes").style.display = "block";
        document.getElementById("formNo").style.display = "none";
      } else if (this.value == "No") {
        document.getElementById("formYes").style.display = "none";
        document.getElementById("formNo").style.display = "block";
      }
    });
  });

  // show / hide q9
  var radiosq9 = document.querySelectorAll("input[type=radio][name=q9]");
  radiosq9.forEach(function (radio) {
    radio.addEventListener("change", function () {
      if (this.value == "Yes") {
        document.getElementById("q9Other").style.display = "block";
      } else if (this.value != "Yes") {
        document.getElementById("q9Other").style.display = "none";
      }
    });
  });
});

// form radio buttons

document.addEventListener("DOMContentLoaded", function () {
  // add class ds-fe-radios__container to all labels that have a radio list fieldset
  var fieldsets = document.querySelectorAll("fieldset.ds-form-radios");

  fieldsets.forEach(function (fieldset) {
    var labels = fieldset.querySelectorAll("label");

    labels.forEach(function (label) {
      label.classList.add("ds-fe-radios__container");
    });
  });

  // add  the class ds-fe-radios__input to all inputs within the a radio label
  var containers = document.querySelectorAll(".ds-fe-radios__container");

  containers.forEach(function (container) {
    var inputs = container.querySelectorAll("input");

    inputs.forEach(function (input) {
      input.classList.add("ds-fe-radios__input");
    });
  });

  // add anew span at the ens of the label to add the radio button
  var containers = document.querySelectorAll(".ds-fe-radios__container");

  containers.forEach(function (container) {
    var span = document.createElement("span");
    span.classList.add("ds-fe-radios__checkmark");

    container.appendChild(span);
  });
});

// form check boxes

document.addEventListener("DOMContentLoaded", function () {
  // add class ds-fe-checkboxes__container to all labels that have a checkbox
  var fieldsets = document.querySelectorAll("div.ds-form-checkboxes");

  fieldsets.forEach(function (fieldset) {
    var labels = fieldset.querySelectorAll("label");

    labels.forEach(function (label) {
      label.classList.add("ds-fe-checkboxes__container");
    });
  });

  // add  the class ds-fe-checkboxes__input to all inputs within the a chckbox label
  var containers = document.querySelectorAll(".ds-fe-checkboxes__container");

  containers.forEach(function (container) {
    var inputs = container.querySelectorAll("input");

    inputs.forEach(function (input) {
      input.classList.add("ds-fe-checkboxes__input");
    });
  });

  // add anew span at the end of the label to add the radio button svg
  var containers = document.querySelectorAll(".ds-fe-checkboxes__container");

  containers.forEach(function (container) {
    var span = document.createElement("span");
    span.classList.add("ds-fe-checkboxes__checkmark");

    const htmlContent =
    '<svg class="ds-fe-checkboxes__icon"><use xlink:href="#ds-general-checkmark" href="#ds-general-checkmark"></use></svg>';
    span.innerHTML = htmlContent;
    container.appendChild(span);
  });
});
