using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RougeGame
{
    public partial class EquipmentScreen : UserControl
    {
        private GameManager _gm;
        //private RandomItemFactory _randomItem;
        //private Item _enemyDroppedLoot;

        public EquipmentScreen(GameManager gm)
        {
            InitializeComponent();
            _gm = gm;

            AddBtn.Enabled = false;
            dropBtn.Enabled = false;
            equipBtn.Enabled = false;
            

            errorLabel.Text = "";
            attackValue.Text = "Attack Value: " + _gm.Player.CalcTotalAttackValue();
            defenseValue.Text = "Defense Value: " + _gm.Player.CalcTotalDefenseValue();

            HeadBtn.Text = string.Format("{0}",
                _gm.Player.Equipped.Equip(InventorySlotId.HELMET,
                new BronzeHelmet())); ;

            WeaponBtn.Text = string.Format("{0}",
                _gm.Player.Equipped.Equip(InventorySlotId.HELMET,
                new BronzeHelmet()));

            BodyBtn.Text = string.Format("{0}",
                _gm.Player.Equipped.Equip(InventorySlotId.CHESTPIECE,
                new BronzeChestpiece()).ToString());

            vambracesBtn.Text = string.Format("{0}",
                _gm.Player.Equipped.Equip(InventorySlotId.VAMBRACES,
                new BronzeVambraces()).ToString());

            grievesBtn.Text = string.Format("{0}",
                _gm.Player.Equipped.Equip(InventorySlotId.GRIEVES,
                new BronzeGrieves()).ToString());

            
            //_randomItem = new RandomItemFactory();
            //    _enemyDroppedLoot = _randomItem.GenerateRandomItem();
            //    lootListBox.Items.Add(_enemyDroppedLoot);

            //if (_gm.Depth == 1)
            //{
            //    lootListBox.Items.Clear();
            //}

            // Save player bag to a variable to simplify code
            var playerBag = _gm.Player.Bag;
            for (int i = 0; i < playerBag.Count; i++)
            {
                bagListBox.Items.Add(playerBag.GetItem(i));
            }
            bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);

            if (_gm.Enemy != null)
            {
                // Save enemy bag to a variable to simplify code
                var enemyBag = _gm.Enemy.Bag;
                for (int i = 0; i < enemyBag.Count; i++)
                {
                    lootListBox.Items.Add(enemyBag.GetItem(i));
                }
            }
        }


        private void BattleBtn_Click_1(object sender, EventArgs e)
        {
            _gm.GenerateRandomEnemy();
            var combatScreen = new CombatScreen(_gm);
            combatScreen.Dock = DockStyle.Fill;
            Controls.Add(combatScreen);
            EquipGroupBox.Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there is an enemy and an item selected
                if (_gm.Enemy != null && lootListBox.SelectedIndex >= 0)
                {
                    Item item = _gm.Enemy.Bag.GetItem(lootListBox.SelectedIndex);
                    _gm.Player.Bag.AddItem(item);
                    _gm.Enemy.Bag.RemoveItem(item);
                    bagListBox.Items.Add(lootListBox.SelectedItem);
                    lootListBox.Items.Remove(lootListBox.SelectedItem);

                    bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
                }
            }
            catch (BagFullException ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.BackColor = Color.Red;
            }
        }

        

        private void dropBtn_Click(object sender, EventArgs e)
        {
            _gm.Player.Bag.RemoveItem((Item)bagListBox.SelectedItem);
            bagListBox.Items.Remove(bagListBox.SelectedItem);

            bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
            
        }

        private void equipBtn_Click(object sender, EventArgs e)
        {
            var item = (Item)bagListBox.SelectedItem;

            Item prevItem = _gm.Player.Equipped.Equip(item.Slot, item);
            _gm.Player.Bag.RemoveItem(item);
            bagListBox.Items.Remove(item);

            if (prevItem != null)
            {
                _gm.Player.PickUp(prevItem);
                bagListBox.Items.Add(prevItem);
            }

            
            bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
            attackValue.Text = "Attack Value: " + _gm.Player.CalcTotalAttackValue();
            defenseValue.Text = "Defense Value: " + _gm.Player.CalcTotalDefenseValue();



            if (_gm.Player.Equipped.GetItem(InventorySlotId.HELMET) != null)
            {
                HeadBtn.Text = _gm.Player.Equipped.GetItem(InventorySlotId.HELMET).ToString();
            }
            if (_gm.Player.Equipped.GetItem(InventorySlotId.CHESTPIECE) != null)
            {
                BodyBtn.Text = _gm.Player.Equipped.GetItem(InventorySlotId.CHESTPIECE).ToString();
            }
            if (_gm.Player.Equipped.GetItem(InventorySlotId.WEAPON) != null)
            {
                WeaponBtn.Text = _gm.Player.Equipped.GetItem(InventorySlotId.WEAPON).ToString();
            }
            if (_gm.Player.Equipped.GetItem(InventorySlotId.GRIEVES) != null)
            {
                grievesBtn.Text = _gm.Player.Equipped.GetItem(InventorySlotId.GRIEVES).ToString();
            }
            if (_gm.Player.Equipped.GetItem(InventorySlotId.VAMBRACES) != null)
            {
                vambracesBtn.Text = _gm.Player.Equipped.GetItem(InventorySlotId.VAMBRACES).ToString();
            }
        }

        private void HeadBtn_Click(object sender, EventArgs e)
        {
            Item item = _gm.Player.Equipped.UnEquip(InventorySlotId.HELMET);

            if (item != null)
            {
                
                _gm.Player.PickUp(item);
                bagListBox.Items.Add(item);
                defenseValue.Text = "Defense Value: " + _gm.Player.CalcTotalDefenseValue().ToString();
                bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
                HeadBtn.Text = "Empty";
            }
        }

        private void BodyBtn_Click(object sender, EventArgs e)
        {
            Item item = _gm.Player.Equipped.UnEquip(InventorySlotId.CHESTPIECE);

            if (item != null)
            {
                _gm.Player.PickUp(item);
                bagListBox.Items.Add(item);
                defenseValue.Text = "Defense Value: " + _gm.Player.CalcTotalDefenseValue().ToString();
                bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
                BodyBtn.Text = "Empty";
            }
        }

        private void WeaponBtn_Click(object sender, EventArgs e)
        {
            Item item = _gm.Player.Equipped.UnEquip(InventorySlotId.WEAPON);

            if (item != null)
            {
                _gm.Player.PickUp(item);
                bagListBox.Items.Add(item);
                attackValue.Text = "Attack Value: " + _gm.Player.CalcTotalAttackValue().ToString();
                bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
                WeaponBtn.Text = "Empty";
            }
        }

        private void vambracesBtn_Click(object sender, EventArgs e)
        {
            Item item = _gm.Player.Equipped.UnEquip(InventorySlotId.VAMBRACES);

            if (item != null)
            {
                _gm.Player.PickUp(item);
                bagListBox.Items.Add(item);
                defenseValue.Text = "Defense Value: " + _gm.Player.CalcTotalDefenseValue().ToString();
                bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
                vambracesBtn.Text = "Empty";
            }
        }

        private void grievesBtn_Click(object sender, EventArgs e)
        {
            Item item = _gm.Player.Equipped.UnEquip(InventorySlotId.GRIEVES);

            if (item != null)
            {
                _gm.Player.PickUp(item);
                bagListBox.Items.Add(item);
                defenseValue.Text = "Defense Value: " + _gm.Player.CalcTotalDefenseValue().ToString();
                bagDisplay.Text = string.Format("Bag ({0} / 20) ", _gm.Player.Bag.Count);
                grievesBtn.Text = "Empty";
            }
        }

        private void bagListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bagListBox.SelectedIndex >= 0)
            {
                equipBtn.Enabled = true;
                dropBtn.Enabled = true;
            }
            else
            {
                equipBtn.Enabled = false;
                dropBtn.Enabled = false;
            }
        }

        private void lootListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lootListBox.SelectedIndex >= 0)
            {
                AddBtn.Enabled = true;
            }
            else
            {
                AddBtn.Enabled = false;
            }
        }
    }
}
