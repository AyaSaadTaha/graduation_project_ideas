var _slicedToArray = function () { function sliceIterator(arr, i) { var _arr = []; var _n = true; var _d = false; var _e = undefined; try { for (var _i = arr[Symbol.iterator](), _s; !(_n = (_s = _i.next()).done); _n = true) { _arr.push(_s.value); if (i && _arr.length === i) break; } } catch (err) { _d = true; _e = err; } finally { try { if (!_n && _i["return"]) _i["return"](); } finally { if (_d) throw _e; } } return _arr; } return function (arr, i) { if (Array.isArray(arr)) { return arr; } else if (Symbol.iterator in Object(arr)) { return sliceIterator(arr, i); } else { throw new TypeError("Invalid attempt to destructure non-iterable instance"); } }; }();

var $id = function $id(id) {
    return document.getElementById(id);
};

var _map = ['login', 'register', 'form'].map(function (id) {
    return $id(id);
}),
    _map2 = _slicedToArray(_map, 3),
    login = _map2[0],
    register = _map2[1],
    form = _map2[2];

[login, register].map(function (element) {
    element.onclick = function () {
        [login, register].map(function ($ele) {
            $ele.classList.remove("active");
        });
        this.classList.add("active");
        this.getAttribute("id") === "register" ? form.classList.add("active") : form.classList.remove("active");
    };
});