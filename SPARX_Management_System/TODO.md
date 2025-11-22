# TODO: Fix Compilation Errors in subscriberview

## Errors to Fix:
1. **Base Class Conflict**: `subscriberview.vb` inherits `Form`, but `subscriberview.Designer.vb` inherits `UserControl`. Change `subscriberview.vb` to inherit `UserControl`.
2. **Missing Resources**: Add missing resource entries for `GreenWifi`, `GreenPeso`, `OrangeBlocked`, `edit`, and `delete` to `Resources.resx` and `Resources.Designer.vb`.
   - Note: `delete.png` is not present in the Resources folder. Need to check if it exists or if it's a different name.
3. **Handles Clause**: Fix `Handles Label1.Click` in `subscriberview.vb` by ensuring `Label1` is declared as `WithEvents` (likely resolved after base class fix).
4. **Variable Conflict**: `defaultBackColor` conflicts with base class property. Declare it as `Shadows` if found.

## Steps:
- [ ] Change inheritance in `subscriberview.vb` from `Form` to `UserControl`.
- [ ] Add missing resources to `Resources.resx`.
- [ ] Update `Resources.Designer.vb` with new properties.
- [ ] Check for `delete.png` or correct name.
- [ ] Search and fix any `defaultBackColor` variable.
- [ ] Test compilation.
