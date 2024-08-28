function TreepickerController($scope, $http, umbRequestHelper, editorService, entityResource, $routeParams) {
    $scope.openTagsPicker = function($event) {
        $event.preventDefault();
        let xPathQuery = "$site/tagsParentSection";
        entityResource.getByQuery(xPathQuery, $routeParams.id, 'Document').then(function (entity) {
            let sectionId = entity != null ? entity.id : -1;
            let contentPicker = {
                title: 'Select Tags',
                section: "content",
                treeAlias: "content",
                filterCssClass: "not-allowed not-published",
                filterAdvanced: true,
                filter: function (node) {
                    return ['tag'].indexOf(node.metaData.contentType) < 0;
                },
                multiPicker: true,
                ignoreUserStartNodes: false,
                startNodeId: sectionId,
                hideHeader: false,
                idType: "udi",
                submit: function (model) {
                    // your submit logic
                    editorService.close();
                    $event.preventDefault();
                },
                close: function () {
                    editorService.close();
                }
            };
            editorService.treePicker(contentPicker);
        });
    };
}