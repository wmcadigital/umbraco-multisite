/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./src/www/ds-templates.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./src/www/pages/templates/campaign-two-columns/campaign-template.js":
/*!***************************************************************************!*\
  !*** ./src/www/pages/templates/campaign-two-columns/campaign-template.js ***!
  \***************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
var pageContents = function pageContents() {
  var contents = document.querySelector('.ds-dynamic-page-contents');

  if (contents != null) {
    var headings = document.querySelectorAll('main h2');
    headings.forEach(function (heading) {
      var str = heading.innerHTML;
      var linkStr = str.toLowerCase().replaceAll(' ', '-');
      var link = "#".concat(linkStr); // add id to all the h2

      heading.setAttribute('id', linkStr); // function to decode htmlentities

      function decodeHtml(html) {
        var txt = document.createElement('textarea');
        txt.innerHTML = html;
        return txt.value;
      } // function to add a link to the page contents


      function createMenuItem() {
        var li = document.createElement('a');
        li.textContent = decodeHtml(str);
        li.setAttribute('href', link);
        return li;
      } // get the page contents


      var menu = document.querySelector('.ds-page-contents'); // add page contents link

      menu.appendChild(createMenuItem());
    });
  }
};

/* harmony default export */ __webpack_exports__["default"] = (pageContents);

/***/ }),

/***/ "./src/www/pages/templates/search/search-template.js":
/*!***********************************************************!*\
  !*** ./src/www/pages/templates/search/search-template.js ***!
  \***********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
function _toConsumableArray(arr) { return _arrayWithoutHoles(arr) || _iterableToArray(arr) || _unsupportedIterableToArray(arr) || _nonIterableSpread(); }

function _nonIterableSpread() { throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method."); }

function _unsupportedIterableToArray(o, minLen) { if (!o) return; if (typeof o === "string") return _arrayLikeToArray(o, minLen); var n = Object.prototype.toString.call(o).slice(8, -1); if (n === "Object" && o.constructor) n = o.constructor.name; if (n === "Map" || n === "Set") return Array.from(o); if (n === "Arguments" || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n)) return _arrayLikeToArray(o, minLen); }

function _iterableToArray(iter) { if (typeof Symbol !== "undefined" && iter[Symbol.iterator] != null || iter["@@iterator"] != null) return Array.from(iter); }

function _arrayWithoutHoles(arr) { if (Array.isArray(arr)) return _arrayLikeToArray(arr); }

function _arrayLikeToArray(arr, len) { if (len == null || len > arr.length) len = arr.length; for (var i = 0, arr2 = new Array(len); i < len; i++) { arr2[i] = arr[i]; } return arr2; }

var searchFilterJs = function searchFilterJs() {
  var showBtn = document.getElementById('show_filter_btn');
  var hideBtn = document.getElementById('hide_filter_btn');
  var showResults = document.getElementById('show_results_btn');
  var searchFilter = document.getElementById('search_filter');

  if (searchFilter) {
    var filterOptions = searchFilter.querySelectorAll('.ds-fe-checkboxes__input');
    filterOptions.forEach(function (option) {
      option.addEventListener('change', function () {
        if (_toConsumableArray(filterOptions).some(function (input) {
          return input.checked;
        })) {
          searchFilter.classList.add('ds-search-filter--has-inputs-checked');
        } else {
          searchFilter.classList.remove('ds-search-filter--has-inputs-checked');
        }
      });
    });

    var showFilter = function showFilter() {
      var show = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : true;

      if (show) {
        searchFilter.classList.add('ds-search-filter--is-open');
        searchFilter.setAttribute('aria-expanded', 'true');
      } else {
        searchFilter.classList.remove('ds-search-filter--is-open');
        searchFilter.setAttribute('aria-expanded', 'false');
      }
    };

    var clearFilters = function clearFilters() {
      filterOptions.forEach(function (option) {
        option.checked = false; // eslint-disable-line no-param-reassign
      });
      searchFilter.classList.remove('ds-search-filter--has-inputs-checked');
    };

    showBtn.addEventListener('click', function (e) {
      e.preventDefault();
      showFilter();
    });
    hideBtn.addEventListener('click', function (e) {
      e.preventDefault();
      showFilter(false);
    });
    document.querySelectorAll('.ds-search-filter__clear-all').forEach(function (clearBtn) {
      clearBtn.addEventListener('click', function (e) {
        e.preventDefault();
        clearFilters();
      });
    });
    showResults.addEventListener('click', function () {
      return showFilter(false);
    });
  }
};

/* harmony default export */ __webpack_exports__["default"] = (searchFilterJs);

/***/ }),

/***/ "./src/www/ds-templates.js":
/*!*************************************!*\
  !*** ./src/www/ds-templates.js ***!
  \*************************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _pages_templates_campaign_two_columns_campaign_template__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./pages/templates/campaign-two-columns/campaign-template */ "./src/www/pages/templates/campaign-two-columns/campaign-template.js");
/* harmony import */ var _pages_templates_search_search_template__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./pages/templates/search/search-template */ "./src/www/pages/templates/search/search-template.js");


window.addEventListener('DOMContentLoaded', Object(_pages_templates_campaign_two_columns_campaign_template__WEBPACK_IMPORTED_MODULE_0__["default"])(), Object(_pages_templates_search_search_template__WEBPACK_IMPORTED_MODULE_1__["default"])());

/***/ })

/******/ });
                        