<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CompoundPrinting/Form1.cs) (VB: [Form1.vb](./VB/CompoundPrinting/Form1.vb))
* [Form1.Designer.cs](./CS/CompoundPrinting/Form1.Designer.cs) (VB: [Form1.Designer.vb](./VB/CompoundPrinting/Form1.Designer.vb))
<!-- default file list end -->
# How to render several grid controls on one printed document


<p><strong>Description</strong>:<br />
I have several grids on different tabs of a TabControl. I want to preview and print all these grids at once, that is have a single Print Preview window and start a single print job.</p><p><strong>Solution</strong>:<br />
<strong>Applies to:</strong><br />
<i>XtraPrinting Library, XtraGrid, XtraTreeList, XtraPivotGrid</i></p><p>You should create a separate <strong>PrintableComponentLink</strong> for each <strong>GridControl</strong>. Then add all these links to a single <strong>CompositeLink</strong>. Finally, you can use the <strong>ShowPreview</strong> or <strong>Print</strong> methods of the composite link as if you were using a single PrintableComponentLink.</p>

<br/>


