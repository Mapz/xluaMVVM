PlayerData = newclass("PlayerData", DataClassBase)

function PlayerData:Data()
    return {
        HP = 100,
        Level = 1,
        Attack = 5,
        Treasure = 100,
        MaxHP = 1000
    }
end

function PlayerData:Computed()
    return {
        HPPercent = function(this)
            if this.MaxHP == nil or this.MaxHP <= 0 then
                return 0
            end
            return tostring(100 * this.HP / this.MaxHP) .. "%"
        end
    }
end
