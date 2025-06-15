# SimpleHWIDSpoofer

A simple HWID (Hardware ID) spoofer for Windows that modifies registry-based hardware identifiers.

![SimpleHWIDSpoofer Interface](https://raw.githubusercontent.com/Lufzys/SimpleHWIDSpoofer/main/simpleHwidSpoofer.PNG)

## ⚠️ Disclaimer

**Educational purposes only. Use at your own risk and ensure compliance with applicable laws.**

## 🚀 Features

- **Hardware Profile GUID**: Changes Windows hardware profile identifier
- **Machine GUID**: Modifies Windows cryptography machine GUID
- **Computer Name**: Randomizes PC name (DESKTOP-XXXXX format)
- **Product ID**: Changes Windows product identifier
- **Simple Interface**: One-click spoofing with logging

## ⚙️ What Gets Modified

- `SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001\HwProfileGuid`
- `SOFTWARE\Microsoft\Cryptography\MachineGuid`
- `SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName\ComputerName`
- `SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProductID`

## 🔒 Requirements

- Windows with .NET Framework
- Administrator privileges
- Registry write permissions

## 🛠️ Technical Details

Built with C# using Windows Registry modification. Generates random GUIDs and alphanumeric strings for new identifiers.

## ⚠️ Important Notes

- **Administrator required** for registry access
- **Restart needed** for full effect
- **Antivirus may flag** due to registry modification
- **System restore recommended** before use

---

**Use responsibly and only on systems you own or have permission to modify.**
