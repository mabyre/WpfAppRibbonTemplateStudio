﻿namespace WpfAppRibbonTemplateStudio.Contracts.Services;

public interface IPersistAndRestoreService
{
    void RestoreData();

    void PersistData();
}