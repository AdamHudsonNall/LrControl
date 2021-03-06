﻿using micdah.LrControlApi.Common.Attributes;

namespace micdah.LrControlApi.Modules.LrUndo
{
    [LuaNativeModule("LrUndo")]
    public interface ILrUndo
    {
        /// <summary>
        ///     Returns true of the redo command is currently enabled.
        /// </summary>
        /// <returns></returns>
        [LuaMethod]
        bool CanRedo(out bool canRedo);

        /// <summary>
        ///     Returns true of the undo command is currently enabled.
        /// </summary>
        /// <returns></returns>
        [LuaMethod]
        bool CanUndo(out bool canUndo);

        /// <summary>
        ///     Redoes the last undone history state.
        /// </summary>
        [LuaMethod]
        bool Redo();

        /// <summary>
        ///     Undoes the last history state.
        /// </summary>
        [LuaMethod]
        bool Undo();
    }
}